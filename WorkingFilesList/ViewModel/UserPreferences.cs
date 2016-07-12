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

using WorkingFilesList.Interface;
using WorkingFilesList.Model;

namespace WorkingFilesList.ViewModel
{
    public class UserPreferences : PropertyChangedNotifier, IUserPreferences
    {
        private int _pathSegmentCount;
        private SortOption _selectedSortOptions;

        /// <summary>
        /// The number of path segments to display, a path segment being either
        /// a single file or directory name that makes up the full name of a file
        /// </summary>
        public int PathSegmentCount
        {
            get
            {
                return _pathSegmentCount;
            }

            set
            {
                if (_pathSegmentCount != value)
                {
                    _pathSegmentCount = value;
                    OnPropertyChanged();
                }
            }
        }

        public SortOption SelectedSortOption
        {
            get
            {
                return _selectedSortOptions;
            }

            set
            {
                if (_selectedSortOptions != value)
                {
                    _selectedSortOptions = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
