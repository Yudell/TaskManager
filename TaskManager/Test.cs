using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media.Effects;
using System.Collections;
using System.Windows.Documents;

namespace TaskManager
{
    internal class Test
    {
        public static ScrollViewer Draw_Stack()
        {
            var myScrollViewer = new ScrollViewer
            {
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto
            };

            myScrollViewer.Content = MyBorder();

            return myScrollViewer;
        }

        private static StackPanel MyBorder()
        {
            StackPanel myStackPanel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };

            return Stack(myStackPanel);
        }

        private static StackPanel Stack( StackPanel stack)
        { 
            stack.Children.Add(Column());
            stack.Children.Add(Column());
            stack.Children.Add(Column());
            stack.Children.Add(Jopumn());
            return stack;
        }
        private static Border Column()
        {
            Border bord = new Border
            {
                Margin = new Thickness(10),
                Background = new SolidColorBrush(Colors.White),
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left,
                Padding = new Thickness(3),
                CornerRadius = new CornerRadius(5),
                Effect = new DropShadowEffect { BlurRadius = 30, Color = Colors.Black, ShadowDepth = 0 }
            };

            StackPanel myStack = new StackPanel();

            var WhatToDo = new Button
            {
                Background = new SolidColorBrush(Colors.Blue),
                Margin = new Thickness(10),
                Width = 225,
                Height = 40,
                Content = "Сделать покушать!"
            };

            var WhatisDoing = new Button
            {
                Margin = new Thickness(20),
                Width = 225,
                Height = 40,
                Content = "+ Карточка"
            };

            myStack.Children.Add(WhatToDo);
            myStack.Children.Add(WhatisDoing);
            bord.Child = myStack;
            return bord;
            }
        private static Border Jopumn()
        {
            Border Man = new Border
            {
                Margin = new Thickness(10),
                Background = new SolidColorBrush(Colors.White),
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Right,
                Padding = new Thickness(3),
                CornerRadius = new CornerRadius(5),
                Effect = new DropShadowEffect { BlurRadius = 30, Color = Colors.Black, ShadowDepth = 0 }
            };
            StackPanel Bruh = new StackPanel();

            Button AddJopumn = new Button
            {
                Background = new SolidColorBrush(Colors.Blue),
                Margin = new Thickness(10),
                Width = 50,
                Height = 40,
                Content = "+"
            };
            AddJopumn.Click += new RoutedEventHandler(AddJopumn_Click);

            Bruh.Children.Add(AddJopumn);
            Man.Child = Bruh;
            return Man;
            
        }
        private static void AddJopumn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
