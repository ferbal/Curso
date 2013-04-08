
namespace Curso.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Curso.ViewModels;

    using Services;

    public class InmuebleController : Controller
    {
        private readonly InmuebleService inmuebleService;
        private readonly RealtyService realtyService;

        public InmuebleController(InmuebleService inmuebleService,RealtyService realtyService)
        {
            this.inmuebleService = inmuebleService;
            this.realtyService = realtyService;
        }

        public ActionResult Index()
        {
            List<InmuebleViewModel> model = this.inmuebleService.GetAll().Select(m => new InmuebleViewModel(m.Id, m.Address, m.Details,m.Realty)).ToList();
            return this.View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = new InmuebleViewModel();
            ViewBag.Selection = null;
            if (id != 0)
            {
                var inmueble = this.inmuebleService.Get(id);
                model = new InmuebleViewModel(inmueble.Id,inmueble.Address,inmueble.Details,model.Realty);
                ViewBag.Selection = inmueble.Realty.Id;
            }
            ViewBag.Categorias = this.realtyService.GetAll().Select(m2 => new RealtyViewModel(m2.Id, m2.Name, m2.Address,m2.Details,m2.Manager)).ToList();
            return this.View(model);            
        }

        public ActionResult Update(InmuebleViewModel model)
        {
            if (model.Id == 0)
            {
                model.Realty = realtyService.Get(model.Realty.Id);
                int LastPos;
                List<InmuebleViewModel> lista = this.inmuebleService.GetAll().Select(m => new InmuebleViewModel(m.Id, m.Address, m.Details,m.Realty)).ToList();
                if (lista.Count() > 0)
                {
                    LastPos = lista.Last(x => x.Id != 0).Id;
                    LastPos = LastPos + 1;
                }
                else
                {
                    LastPos = 1;
                }
                this.inmuebleService.Create(LastPos,model.Address, model.Details,model.Realty);

            }
            else
            {
                this.inmuebleService.Update(model.Id, model.Address, model.Details,model.Realty);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            this.inmuebleService.Delete(id);
            return this.RedirectToAction("Index");
        }
    }
}
