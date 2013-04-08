
namespace Curso.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Curso.ViewModels;
    using Domain;

    using Services;

    public class InterestedController : Controller
    {
        private readonly InterestedService interestedService;
        private readonly InmuebleService inmuebleService;

        public InterestedController(InterestedService interestedService,InmuebleService inmuebleService)
        {
            this.interestedService = interestedService;
            this.inmuebleService = inmuebleService;
        }

        public ActionResult Index()
        {
            List<InterestedViewModel> model = this.interestedService.GetAll().Select(m => new InterestedViewModel(m.Id, m.Name, m.Phone, m.Homes)).ToList();            
            return this.View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = new InterestedViewModel();
            
            if (id != 0)
            {
                var interested = this.interestedService.Get(id);
                model = new InterestedViewModel(interested.Id,interested.Name,interested.Phone, interested.Homes);

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
                this.interestedService.Update(model.Id, model.Name, model.Phone,model.Homes);               
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            this.interestedService.Delete(id);
            return this.RedirectToAction("Index");
        }        

        public ActionResult EditHomes(int id)
        {                        
            Interested interested = interestedService.Get(id);
            IList<Home> homes = interested.Homes;
            List<InmuebleViewModel> model = this.inmuebleService.GetAll().Select(m => new InmuebleViewModel(m.Id, m.Address, m.Details, m.Realty)).ToList();
            List<InmuebleViewModel> lista= new List<InmuebleViewModel>() ;
            if (homes.Count()!=0)
            {
                foreach (var h in homes)
                {
                    foreach (var m in model)
                    {
                        if (m.Id != h.Id)
                        {
                            lista.Add(m);
                        }
                    }

                }
            }
            else
            {
                lista = model;
            }
            ViewBag.InterestedId = id;
            return this.View(lista);            
        }

        public ActionResult AddForInterested(int id, int id2)
        {
            Interested interested = this.interestedService.Get(id2);
            interested.Homes.Add(inmuebleService.Get(id));
            this.interestedService.Update(interested.Id, interested.Name, interested.Phone, interested.Homes);
            ViewBag.InterestedId = id;
            return this.RedirectToAction("Index");
        }

        public ActionResult ListHomes(int id)
        {
            Interested interested = interestedService.Get(id);
            IList<Home> homes = interested.Homes;
            ViewBag.InterestedId = id;
            return this.View(homes);
        }

        public ActionResult DeleteFromInterested(int id, int id2)
        {                                     
            this.interestedService.DelHomeFromList(id2,id);
            return this.RedirectToAction("Index");
        }
    }
}
