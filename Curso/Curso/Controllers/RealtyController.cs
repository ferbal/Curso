
namespace Curso.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Curso.ViewModels;

    using Services;

    public class RealtyController : Controller
    {
        private readonly RealtyService realtyService;
        private readonly ManagerService managerService;        

        public RealtyController(RealtyService realtyService, ManagerService managerService)
        {
            this.realtyService = realtyService;
            this.managerService = managerService;
        }

        public ActionResult Index()
        {
            List<RealtyViewModel> model = this.realtyService.GetAll().Select(m => new RealtyViewModel(m.Id,m.Name, m.Address, m.Details, m.Manager)).ToList();            
            return this.View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = new RealtyViewModel();
            ViewBag.Selection = null;
            if (id != 0)
            {                
                var realty = this.realtyService.Get(id);
                model = new RealtyViewModel(realty.Id, realty.Name, realty.Address, realty.Details,realty.Manager);
                ViewBag.Selection = realty.Manager.Id;
            }            
            ViewBag.Categorias = this.managerService.GetAll().Select(m2 => new ManagerViewModel(m2.Id, m2.Name, m2.Age)).ToList();
            return this.View(model);            
        }

        public ActionResult Update(RealtyViewModel model,FormCollection form)
        {            
            if (model.Id == 0)
            {
                model.Manager = managerService.Get(model.Manager.Id);
                int LastPos;
                List<RealtyViewModel> lista = this.realtyService.GetAll().Select(m => new RealtyViewModel(m.Id, m.Name, m.Address, m.Details,m.Manager)).ToList();
                if (lista.Count() > 0)
                {
                    LastPos = lista.Last(x => x.Id != 0).Id;
                    LastPos = LastPos + 1;
                }
                else
                {
                    LastPos = 1;
                }
                this.realtyService.Create(LastPos,model.Name,model.Address, model.Details,model.Manager);
                //this.realtyService.Update(LastPos, model.Name, model.Address, model.Details, model.Manager);
                //model.Manager.Realties.Add(realtyService.Get(LastPos));   
                this.managerService.AddRealty(LastPos, this.realtyService.Get(LastPos));
            }
            else
            {
                this.realtyService.Update(model.Id, model.Name, model.Address, model.Details,model.Manager);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            this.realtyService.Delete(id);
            return this.RedirectToAction("Index");
        }
    }
}
