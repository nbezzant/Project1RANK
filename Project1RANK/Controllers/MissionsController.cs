using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project1RANK.Models;

namespace Project1RANK.Controllers
{
    public class MissionsController : Controller
    {

        public static List<Mission> lstMissions = new List<Mission>()
        {
            new Mission{ Mission_ID = 1,
                            Mission_Name = "Taiwan Taipei Mission",
                            Mission_President_Name = "Jace Jergensen",
                            Mission_Address = "台北傳道部 台北市大安區金華街183巷24號4樓",
                            Mission_Language = "Mandarin Chinese",
                            Mission_Climate = "Hot and Humid",
                            Mission_Religion = "Buddhist and Daoist",
                            Mission_Flag = "taiwan.png"
                                    },

            new Mission{ Mission_ID = 2,
                            Mission_Name = "Poland Warsaw Mission",
                            Mission_President_Name = "Matteusz Zbigniew Turek",
                            Mission_Address = "Kościół Jezusa Chrystusa Świętych w Dniach Ostatnich Ul. Wiertnicza 135 02-952 Warszawa Poland",
                            Mission_Language = "Polish",
                            Mission_Climate = "Temperate",
                            Mission_Religion = "Catholic",
                            Mission_Flag = "poland.png"
                                    },

            new Mission{ Mission_ID = 3,
                            Mission_Name = "Brazil Recife Mission",
                            Mission_President_Name = "Rory Bigelow",
                            Mission_Address = " Rua Das Ninfas 30 Boa Vista 50070-055 Recife – PE Brazil",
                            Mission_Language = "Portuguese",
                            Mission_Climate = "Hot and Humid",
                            Mission_Religion = "Evangelical Christian",
                            Mission_Flag = "brazil.png"
                                    },

                        new Mission{ Mission_ID = 4,
                            Mission_Name = "Brazil Sao Paulo Interlagos Mission",
                            Mission_President_Name = "Cary Dalton",
                            Mission_Address = "Rua Comendador Elias Zarzur, 365 - Santo Amaro, São Paulo - SP, 04736-000, Brazil",
                            Mission_Language = "Portuguese",
                            Mission_Climate = "Dry Heat",
                            Mission_Religion = "Catholic",
                            Mission_Flag = "brazil.png"
                                    }
        };



        // GET: Missions
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult SelectMission()
        {
            ViewBag.Missions = lstMissions;
            return View(lstMissions);
        }

        public ActionResult ShowMission(Mission mission)
        {
            var oMission = lstMissions.Find(id => id.Mission_ID == mission.Mission_ID);
            return View(oMission);
        }

        [HttpGet]
        public ActionResult ChooseMission()
        {
            ViewBag.Missions = lstMissions;
            return View();
        }

        [HttpPost]
        public ActionResult ChooseMission(Mission mission)
        {
            var oMission = lstMissions.Find(id => id.Mission_ID == mission.Mission_ID);

            return RedirectToAction("ShowMission", "Missions", oMission);
        }

    }
}