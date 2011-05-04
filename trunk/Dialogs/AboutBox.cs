using System;
using System.Reflection;
using System.Windows.Forms;
using System.Text;

namespace WebServiceStudio.Dialogs
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyTitle;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        static public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != string.Empty)
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        static public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                StringBuilder desc = new StringBuilder();
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length != 0)
                {
                    desc.Append(((AssemblyDescriptionAttribute)attributes[0]).Description);
                }
                desc.AppendLine(" by Adam Lesień (adam.lesien@gmail.com)"); 
                desc.AppendLine("based on WebServiceStudio by Adnan Masood (adnanmasood@gmail.com)");
                desc.AppendLine();
                desc.AppendLine("+ UI improvement"); 
                desc.AppendLine("+ Generic nullable types enabled"); 
                desc.AppendLine("+ Client certificate support"); 
                desc.AppendLine("+ Some refactoring"); 
                desc.AppendLine("+ Macro player, syntax:");
                desc.AppendLine();
                desc.AppendLine("     WSDL uri - gets wdsl"); 
                desc.AppendLine("     SET class field value - sets a value of the field in given class"); 
                desc.AppendLine("     INVOKE method - invokes a method"); 
                desc.AppendLine("     COPY srcClass srcField dstClass dstField - copies value of output tree to input tree"); 
                desc.AppendLine("     LOGC comment - saves a comment in a log file (no white spaces in comment)"); 
                desc.AppendLine("     LOGO class field - saves a value of output field of the class in a log file"); 
                desc.AppendLine("     LOGT METHODS/INPUT/OUTPUT - saves selected tree in a log file");
                desc.AppendLine("     IFGOTO class field value label - if field of the class has value goes to label");
                return desc.ToString();
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return string.Empty;
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
