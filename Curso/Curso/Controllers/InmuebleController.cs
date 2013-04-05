
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

        public InmuebleController(InmuebleService inmuebleService)
        {
            this.inmuebleService = inmuebleService;
        }

        public ActionResult Index()
        {
            // TIP: Este codigo es equivalente al de abajo
            // List<ManagerViewModel> model = new List<ManagerViewModel>();
            // foreach (var m in managerService.GetAll())
            // {
            //    model.Add(new ManagerViewModel(m.Id, m.Name, m.Age));
            // }

            List<InmuebleViewModel> model = this.inmuebleService.GetAll().Select(m => new InmuebleViewModel(m.Id, m.Address, m.Details)).ToList();
            return this.View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = new InmuebleViewModel();
            
            if (id != 0)
            {
                var inmueble = this.inmuebleService.Get(id);
                model = new InmuebleViewModel(inmueble.Id,inmueble.Address,inmueble.Details);
            }

            return this.View(model);            
        }

        public ActionResult Update(InmuebleViewModel model)
        {
            if (model.Id == 0)
            {
                this.inmuebleService.Create(model.Address, model.Details);
            }
            else
            {
                this.inmuebleService.Update(model.Id, model.Address, model.Details);
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
