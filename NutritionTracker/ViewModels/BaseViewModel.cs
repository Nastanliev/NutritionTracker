﻿namespace NutritionTracker.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;
        [ObservableProperty]
        string title;
        public bool IsNotBusy => !IsBusy;

        public BaseViewModel()
        {
        }

    }
}
