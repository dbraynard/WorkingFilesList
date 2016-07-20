﻿// WorkingFilesList
// Visual Studio extension tool window that shows a selectable list of files
// that are open in the editor
// Copyright(C) 2016 Anthony Fung

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program. If not, see<http://www.gnu.org/licenses/>.

using System.ComponentModel;
using WorkingFilesList.Interface;

namespace WorkingFilesList.Model.SortOption
{
    /// <summary>
    /// Represents an option for criteria on sorting the displayed document
    /// metadata
    /// </summary>
    public abstract class SortOptionBase : ISortOption
    {
        /// <summary>
        /// Name that this set of sorting criteria will be displayed as. Should
        /// be unique.
        /// </summary>
        public string DisplayName { get; }

        /// <summary>
        /// Name of the property used as sorting criteria
        /// </summary>
        public string PropertyName { get; }

        /// <summary>
        /// Direction that sorting should occur
        /// </summary>
        public ListSortDirection SortDirection { get; }

        protected SortOptionBase(
            string displayName,
            string propertyName,
            ListSortDirection sortDirection)
        {
            DisplayName = displayName;
            PropertyName = propertyName;
            SortDirection = sortDirection;
        }

        /// <summary>
        /// Creates a <see cref="SortDescription"/> that can be added to the
        /// sort descriptions of an <see cref="ICollectionView"/>
        /// </summary>
        /// <returns>
        /// A <see cref="SortDescription"/> that describes the sorting criteria
        /// represented by this <see cref="ISortOption"/> instance
        /// </returns>
        public SortDescription GetSortDescription()
        {
            var sortDescription = new SortDescription(
                PropertyName,
                SortDirection);

            return sortDescription;
        }
    }
}
