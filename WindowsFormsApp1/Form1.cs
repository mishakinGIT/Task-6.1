using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private List<Type> sportTypes;
        private Type selectedType;
        private object selectedObject;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string assemblyPath = @"C:\Users\misha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\ClassLibrary1.dll"; //Ваш путь к ClassLibrary.dll
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            sportTypes = assembly.GetTypes()
                .Where(t => typeof(ISportType).IsAssignableFrom(t) && !t.IsInterface)
                .ToList();
            foreach (Type type in sportTypes)
            {
                sportComboBox.Items.Add(type.Name);
            }
        }

        private void sportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = sportTypes[sportComboBox.SelectedIndex];
            selectedObject = Activator.CreateInstance(selectedType);
            methodComboBox.Items.Clear();
            parameterTextBox.Text = "";
            resultLabel.Text = "";
            MethodInfo[] methods = selectedType.GetMethods();
            foreach (MethodInfo method in methods)
            {
                methodComboBox.Items.Add(method.Name);
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (selectedObject == null || methodComboBox.SelectedItem == null)
            {
                return;
            }
            string methodName = methodComboBox.SelectedItem.ToString();
            MethodInfo method = selectedType.GetMethod(methodName);
            ParameterInfo[] parameters = method.GetParameters();
            object[] methodParameters = new object[parameters.Length];
            if (parameters.Length > 0)
            {
                string parameterValue = parameterTextBox.Text;
                for (int i = 0; i < parameters.Length; i++)
                {
                    ParameterInfo parameter = parameters[i];

                    try
                    {
                        methodParameters[i] = Convert.ChangeType(parameterValue, parameter.ParameterType);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Неверный формат параметра");
                        return;
                    }
                }
            }
            object result = method.Invoke(selectedObject, methodParameters);

            resultLabel.Text = "Результат: " + result.ToString();
        }
        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
