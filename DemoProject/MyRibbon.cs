using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace DemoProject
{
    public partial class MyRibbon
    {
        private void MyRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Data_Click(object sender, RibbonControlEventArgs e)
        {
            userdataform userform = new userdataform();
            userform.ShowDialog();
        }

        private void Search_Click(object sender, RibbonControlEventArgs e)
        {
            SearchUser searchuserform = new SearchUser();
            searchuserform.ShowDialog();
        }
    }
}
