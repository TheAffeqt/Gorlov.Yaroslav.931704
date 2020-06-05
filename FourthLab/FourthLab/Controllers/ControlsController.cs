using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FourthLab.Models;

namespace FourthLab.Controllers
{
    public class ControlsController : Controller
    {
        static ControlModel controls = new ControlModel();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TextBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextBox(string TB)
        {
            ControlModel cm = new ControlModel
            {
                ControlElement = "Text Box",
                Result = TB,
                Name = "Text: "
            };
            return View("ResultControl", cm);
        }

        [HttpGet]
        public IActionResult TextArea()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextArea(string TA)
        {
            ControlModel cm = new ControlModel
            {
                ControlElement = "Text Area",
                Result = TA,
                Name = "Text: "
            };
            return View("ResultControl", cm);
        }


        [HttpGet]
        public IActionResult CheckBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckBox(bool isSelected)
        {
            ControlModel cm = new ControlModel
            {
                ControlElement = "Check Box",
                Name = "Selected"
            };
            if (isSelected == false)
            {
                cm.Result = "False";
            }
            else
            {
                cm.Result = "True";
            }
            return View("ResultControl", cm);
        }

        [HttpGet]
        public IActionResult Radio()
        {
            ViewBag.Radio = controls.Radio;
            return View();
        }

        [HttpPost]
        public IActionResult Save_Radio(string Radio)
        {
            controls.Radio = Radio;
            ViewBag.Radio = controls.Radio;
            return View("Radio");
        }

        [HttpGet]
        public IActionResult DropDownList()
        {
            ViewBag.DropDownList = controls.DropDownList;
            return View();
        }

        [HttpPost]
        public IActionResult Save_DropDownList(string DropDownList)
        {
            controls.DropDownList = DropDownList;
            ViewBag.DropDownList = controls.DropDownList;
            return View("DropDownList");
        }

        [HttpGet]
        public IActionResult ListBox()
        {
            ViewBag.ListBox = controls.ListBox;
            return View();
        }

        [HttpPost]
        public IActionResult Save_ListBox(string ListBox)
        {
            controls.ListBox = ListBox;
            ViewBag.ListBox = controls.ListBox;
            return View("ListBox");
        }

    }
}