﻿using Demo.Common;

namespace Demo.Clip04;

class PrintedBook : IBook
{
    public string Title { get; }
    public Size Dimensions { get; }
        
    public PrintedBook(string title, Size dimensions)
    {
        this.Title = title;
        this.Dimensions = dimensions;
    }
        
    public Size GetDimensions(Size propaganda) =>
        this.Dimensions.AddToTop(propaganda);

    public override string ToString() =>
        $"{this.Title} - {this.Dimensions}";
}