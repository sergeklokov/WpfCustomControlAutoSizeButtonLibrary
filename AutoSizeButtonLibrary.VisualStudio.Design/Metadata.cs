using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows;

using AutoSizeButtonLibrary;
using Microsoft.Windows.Design.Features;
using Microsoft.Windows.Design.Metadata;
using AutoSizeButtonLibrary.VisualStudio.Design;

// The ProvideMetadata assembly-level attribute indicates to designers
// that this assembly contains a class that provides an attribute table. 
[assembly: ProvideMetadata(typeof(AutoSizeButtonLibrary.VisualStudio.Design.Metadata))]
namespace AutoSizeButtonLibrary.VisualStudio.Design
{
    // Container for any general design-time metadata to initialize.
    // Designers look for a type in the design-time assembly that 
    // implements IProvideAttributeTable. If found, designers instantiate 
    // this class and access its AttributeTable property automatically.
    internal class Metadata : IProvideAttributeTable
    {
        // Accessed by the designer to register any design-time metadata.
        public AttributeTable AttributeTable
        {
            get
            {
                AttributeTableBuilder builder = new AttributeTableBuilder();

                builder.AddCustomAttributes(
                    typeof(AutoSizeButton),
                    new FeatureAttribute(typeof(AutoSizeAdornerProvider)));

                return builder.CreateTable();
            }
        }
    }
}
