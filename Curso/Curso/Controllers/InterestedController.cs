
namespace Curso.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Curso.ViewModels;

    using Services;

    public class InterestedController : Controller
    {
        private readonly InterestedService interestedService;

        public InterestedController(InterestedService interestedService)
        {
            this.interestedService = interestedService;
        }

        public ActionResult Index()
        {
            // TIP: Este codigo es equivalente al de abajo
            // List<ManagerViewModel> model = new List<ManagerViewModel>();
            // foreach (var m in managerService.GetAll())
            // {
            //    model.Add(new ManagerViewModel(m.Id, m.Name, m.Age));
            // }

            List<InterestedViewModel> model = this.interestedService.GetAll().Select(m => new InterestedViewModel(m.Id, m.Name, m.Phone)).ToList();
            return this.View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = new InterestedViewModel();
            
            if (id != 0)
            {
                var interested = this.interestedService.Get(id);
                model = new InterestedViewModel(interested.Id,interested.Name,interested.Phone);
            }

            return this.View(model);            
        }

        public ActionResult Update(InterestedViewModel model)
        {
            if (model.Id == 0)
            {
                this.interestedService.Create(model.Name, model.Phone);
            }
            else
            {
                this.interestedService.Update(model.Id, model.Name, model.Phone);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            this.interestedService.Delete(id);
            return this.RedirectToAction("Index");
        }
    }
}
