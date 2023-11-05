using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using BusinessObject.Models;

namespace WebApp.Controllers
{
    public class PetController : Controller
    {
        public PetShopProjectContext context = new PetShopProjectContext();
        public IActionResult List()
        {
            List<Pet> pets = context.Pets.ToList();
            return View(pets);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string InputEmail, string InputPassword)
        {
            if (ModelState.IsValid)
            {
                var user = context.PetShopMembers.FirstOrDefault(u => u.EmailAddress == InputEmail && u.MemberPassword == InputPassword && u.MemberRole == 2);

                if (user != null)
                {
                    TempData["idmem"] = user.MemberId;
                    return RedirectToAction("Success");
                }
                else
                {

                }
            }

            return View();
        }
        public IActionResult Success()
        {
            return RedirectToAction("List");
        }
        public IActionResult Search(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                var allPets = context.Pets.ToList();
                return View(allPets);
            }
            var searchResults = context.Pets.Where(p => p.PetName.Contains(searchTerm)).ToList();

            return View(searchResults);
        }
        [HttpGet]
        public ActionResult Order(int petId)
        {
            var searchResults = context.Pets.SingleOrDefault(p => p.PetId == petId);
            return View(searchResults);
        }
        [HttpPost]
        public IActionResult Order(int petId, int quantity)
        {
            string idmem = TempData["idmem"] as string;
            var pet = context.Pets.FirstOrDefault(p => p.PetId == petId);
            int maxOrderId = context.MemberOrders.Max(o => o.Id);

            // Tạo ID mới bằng cách cộng giá trị lớn nhất với 1
            int newOrderId = maxOrderId + 1;
            if (pet != null)
            {
                int currentQuantity = pet.Quantity ?? 0;
                int newQuantity = currentQuantity - quantity;

                if (newQuantity >= 0)
                {

                    pet.Quantity = newQuantity;

                    var order = new MemberOrder
                    {
                        Id = newOrderId,
                        Quantity = quantity,
                        TotalPrice = quantity * (int)context.Pets.FirstOrDefault(p => p.PetId == petId).PetPrice,
                        MemberId = idmem,
                        PetId = petId,
                    };

                    context.MemberOrders.Add(order);
                    context.SaveChanges();

                    return RedirectToAction("OrderSuccesed", new { ID = order.Id });
                }
            }

            return RedirectToAction("OrderFailed");
        }


        [HttpGet]
        public ActionResult OrderSuccesed(int ID)
        {
            var searchResults = context.MemberOrders.SingleOrDefault(p => p.Id == ID);
            return View(searchResults);
        }

    }
}

