using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using Lab4RA201701.Models;
using DotVVM.BusinessPack.Controls;

namespace Lab4RA201701.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        public string Title { get; set; }
        public PersonModel Person { get; set; } = new PersonModel { EnrollmentDate = DateTime.UtcNow.Date };
        public bool IsWindowDisplayed { get; set; }
        public UploadData ProfilePicture { get; set; } = new UploadData();
        public DefaultViewModel()
        {
            Title = "RA201701 LAB 4 - Person Form";
        }
        public void Process()
        {
            this.IsWindowDisplayed = false;
            String script = "alert('" + "Welcome" + " " + Person.Username + " to Web App :) ')";
            Context.ResourceManager.AddStartupScript(script);
        }
        public void ProcessFile()
        {
            // do what you have to do with the uploaded files
            String script = "alert('" + "ProcessFile() was called.')";
            Context.ResourceManager.AddStartupScript(script);
        }

        public void SetVisible()
        {
            IsWindowDisplayed = true;
        }
    }

}
