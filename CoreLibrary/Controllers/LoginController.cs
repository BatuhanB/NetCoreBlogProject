using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreLibrary.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous] //Sadece bu sayfaya yetki veriyoruz
        public IActionResult Index()
        {
            return View();
        }

        //Bu kısımda da authentication işlemi yapıyoruz
        //Once mail adresimizi ve sifremizi bir degiskene atiyoruz. Ardindan eger ki bu gelen degerler dogru geliyorsa
        //bir claim listesi olusturuyoruz ve claim tokenimiz mail adresimiz oluyor.
        //Yeni bir claim dogrulama degiskeni aliyoruz ve asenkron olarak kontrol ettikten sonra Writer controller da ki index sayfamiza yonlendiriyor.
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        { 
            Context context = new Context();    
            var datavalue = context.Writers.FirstOrDefault(x=>x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if(datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.WriterMail)
                };
                var ClaimIdentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(ClaimIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Writer");
            }
            else
            {
                return View();
            }    
        }
    }
}

//Context context = new Context();
//var dataValue = context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
//if (dataValue != null)
//{
//    HttpContext.Session.SetString("username", writer.WriterMail);
//    return RedirectToAction("Index", "Writer");
//}
//else
//{
//    return View();
//}
