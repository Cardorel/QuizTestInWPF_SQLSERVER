using ProjectKoursova.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectKoursova.Helpers
{
    internal class ContentTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {

            FrameworkElement element = container as FrameworkElement;
            if (element == null || item == null)
            {
                return null;
            }

            if (item is CSharpQuizViewModel)
            {
                return (DataTemplate)element.FindResource("CSharpQuizViewModel");
            }
            else if (item is StudentViewModel)
            {
                return (DataTemplate)element.FindResource("StudentViewModel");
            }
            return base.SelectTemplate(item, container);
        }
    }
}