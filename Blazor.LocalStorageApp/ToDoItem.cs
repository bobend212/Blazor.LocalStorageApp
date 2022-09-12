﻿namespace Blazor.LocalStorageApp
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsChecked { get; set; }
    }
}