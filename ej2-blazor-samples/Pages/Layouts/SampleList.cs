﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Card { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "BasicCard",
                Category = "Card",
                Directory = "Layouts/Card",
                FileName = "BasicCard.razor",
                Url = "Card/BasicCard",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "VerticalCard",
                Category = "Card",
                Directory = "Layouts/Card",
                FileName = "VerticalCard.razor",
                Url = "Card/VerticalCard",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "HorizontalCard",
                Category = "Card",
                Directory = "Layouts/Card",
                FileName = "HorizontalCard.razor",
                Url = "Card/HorizontalCard",
                Type = SampleType.New
            },
        };
		public List<Sample> Listview { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Listview",
                Directory = "Layouts/Listview",
                Url = "Listview/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            }
        };
        public List<Sample> Avatar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Avatar",
                Directory = "Layouts/Avatar",
                Url = "Avatar/Default",
                FileName = "Default.razor",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Badge",
                Category = "Avatar",
                Directory = "Layouts/Avatar",
                Url = "Avatar/Types",
                FileName = "Types.razor",
                Type = SampleType.New,
            }
        };
         public List<Sample> DashboardLayout { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Dashboard Layout",
                Directory = "Layouts/DashboardLayout",
                Url = "DashboardLayout/Default",
                FileName = "Default.razor",
                Type = SampleType.New
            }
        };
        public List<Sample> Splitter { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Splitter",
                Directory = "Layout/Splitter",
                Url = "Splitter/Default",
                FileName = "Default.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Expand and Collapse",
                Category = "Splitter",
                Directory = "Layouts/Splitter",
                Url = "Splitter/ExpandandCollapse",
                FileName = "ExpandandCollapse.razor",
                Type = SampleType.New
            },
        };
    }

   


}
