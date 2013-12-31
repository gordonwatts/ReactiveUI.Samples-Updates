﻿
using System;
namespace ReactiveUI.Samples.SimpleViewModels
{
    public interface IWebCaller
    {
        /// <summary>
        /// Return the web service call string result given the input.
        /// Can take an indeterminent amount of time.
        /// </summary>
        /// <param name="searchItems"></param>
        /// <returns></returns>
        IObservable<string> GetResult(string searchItems);
    }
}