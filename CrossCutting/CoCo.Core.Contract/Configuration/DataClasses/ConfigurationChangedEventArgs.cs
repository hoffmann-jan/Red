﻿namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration.DataClasses
{
    public class ConfigurationChangedEventArgs<TResult>
    {
        public TResult OldValue { get; set; }
        public TResult NewValue { get; set; }
        public string Category { get; set; }
        public string Key { get; set; }
        public ChangeReason Reason { get; set; }
    }
}
