﻿using System;
using System.Globalization;
using MvvmFx.Bindings.Data;
using MvvmFx.Bindings.Specifications.Support.Entities;

namespace MvvmFx.Bindings.Specifications.Support.Converters
{
    public class GenderConverter : IValueConverter
    {
        public object Convert(object value, Type type, object parameter, CultureInfo culture)
        {
            return value == null ? null : value.ToString();
        }

        public object ConvertBack(object value, Type type, object parameter, CultureInfo culture)
        {
            switch (value as string)
            {
                case "Male":
                    return Gender.Male;
                case "Female":
                    return Gender.Female;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}