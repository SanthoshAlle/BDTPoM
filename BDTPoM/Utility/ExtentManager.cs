using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BDTPoM.Utility
{
    public class ExtentManager
    {
        private static ExtentReports extent;
            public static ExtentReports getInstance()
        {
            if (extent==null)
            {
                string filename = DateTime.UtcNow.ToString("yyyy-mm-dd-ss") + ".html";
                string reportPath = "D:\\alle\\test\\reports" + filename;
                extent = new ExtentReports(reportPath, true, DisplayOrder.NewestFirst);
                extent.LoadConfig(@"C:\Users\sa7admin\source\repos\BDTPoM\BDTPoM\Extent-Config.xml");
                extent.AddSystemInfo("selenium Version", "Selenium 3.8").AddSystemInfo("Tester", "Shyam").AddSystemInfo("Company", "BDT");
            }

          return extent;
        }

    }
}
