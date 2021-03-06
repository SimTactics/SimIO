/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/

using System.Drawing;

namespace SimIO.Providers
{
    public class CollectibleAlias
    {
        public string Name { get; }

        public ulong Id { get; }

        public int Nr { get; }

        public Image Image { get; }


        public CollectibleAlias(ulong id, int nr, string name, Image img)
        {
            Id = id;
            Nr = nr;
            Name = name;
            if (img == null)
            {
                img = new Bitmap(32, 32);
            }
            Image = img;
        }

        public override string ToString()
        {
#if DEBUG
            return $"{Name} (0x{Helper.HexString(Id)}, {Nr})";
#else
            return Name;
#endif
        }
    }
}
