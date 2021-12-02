using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WADE_TechTalkDemo.Models;

namespace WADE_TechTalkDemo.Pages
{
    public partial class Details
    {
        public Concept item { get; set; }
        [Inject]
        public ConceptApiClient client { get; set; }
        public string TableSortId { get; set; }
        public MatSortDirection TableSortDirection { get; set; }
        protected override async Task OnInitializedAsync()
        {
            item = new Concept();
            if (State.currentConceptUri != null)
            {
                item = await client.GetConceptDetails(State.currentConceptUri);
            }
        }
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                this.item = new Concept();
            }
        }
        public async void ChangeConcept(string uri)
        {
            State.currentConceptUri=uri;
            item = await client.GetConceptDetails(State.currentConceptUri);
            await InvokeAsync(() => StateHasChanged());
        }
        void SortDataRelated(MatSortChangedEvent sort)
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
                        item.Related.Sort((s1, s2) => -1 * comparison(s1, s2));
                    }
                    else
                    {
                        item.Related.Sort(comparison);
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
        void SortDataBroader(MatSortChangedEvent sort)
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
                        item.Broader.Sort((s1, s2) => -1 * comparison(s1, s2));
                    }
                    else
                    {
                        item.Broader.Sort(comparison);
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

        void SortDataNarrower(MatSortChangedEvent sort)
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
                        item.Broader.Sort((s1, s2) => -1 * comparison(s1, s2));
                    }
                    else
                    {
                        item.Broader.Sort(comparison);
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
