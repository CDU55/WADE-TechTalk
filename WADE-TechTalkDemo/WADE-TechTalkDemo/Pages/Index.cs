using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WADE_TechTalkDemo.Models;

namespace WADE_TechTalkDemo.Pages
{
    public partial class Index
    {
        public List<Concept> items { get; set; }
        [Inject]
        public ConceptApiClient client { get; set; }
        [Inject]
        public NavigationManager manager { get; set; }
        public string TableSortId { get; set; }
        public MatSortDirection TableSortDirection { get; set; }
        protected override async Task OnInitializedAsync()
        {
            items = await client.GetConcepts();
        }
        public void GoToDetails(string uri)
        {
            State.currentConceptUri = uri;
            manager.NavigateTo("details", forceLoad: true);
        }
        void SortData(MatSortChangedEvent sort)
        {
            var sorted = false;
            if (!(sort == null || sort.Direction == MatSortDirection.None || string.IsNullOrEmpty(sort.SortId)))
            {
                Comparison<Concept> comparison = null;
                switch (sort.SortId)
                {
                    case "PrefLabelEng":
                        comparison = (s1, s2) => string.Compare(s1.PrefLabelEng, s2.PrefLabelEng, StringComparison.InvariantCultureIgnoreCase);
                        break;
                    case "PrefLabelDe":
                        comparison = (s1, s2) => string.Compare(s1.PrefLabelDe, s2.PrefLabelDe, StringComparison.InvariantCultureIgnoreCase);
                        break;
                    case "Resource":
                        comparison = (s1, s2) => string.Compare(s1.Uri, s2.Uri, StringComparison.InvariantCultureIgnoreCase);
                        break;
                }
                if (comparison != null)
                {
                    if (sort.Direction == MatSortDirection.Desc)
                    {
                        items.Sort((s1, s2) => -1 * comparison(s1, s2));
                    }
                    else
                    {
                        items.Sort(comparison);
                    }

                    sorted = true;
                    TableSortId = sort.SortId;
                    TableSortDirection = sort.Direction;
                }
            }
            if (!sorted)
            {
                TableSortId = null;
                TableSortDirection = MatSortDirection.None;
            }
        }
    }
}
