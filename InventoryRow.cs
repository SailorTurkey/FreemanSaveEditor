using QuickType;
using System;
using System.Collections.Generic;

namespace FreemanSaveEditor
{
    public class InventoryRow
    {
        public long Col1 { get; set; }
        public long Col2 { get; set; }
        public long Col3 { get; set; }
        public long Col4 { get; set; }

        public static int ColCount { get; } = 4;

        public int EmptyCount
        {
            get
            {
                return
                    Col1 == 0 ? 1 : 0 +
                    Col2 == 0 ? 1 : 0 +
                    Col3 == 0 ? 1 : 0 +
                    Col4 == 0 ? 1 : 0;
            }
        }

        public long this[int idx]
        {
            get
            {
                switch (idx)
                {
                    case 0:
                        return Col1;

                    case 1:
                        return Col2;

                    case 2:
                        return Col3;

                    case 3:
                        return Col4;

                    default:
                        throw new NotImplementedException();
                }
            }
            set
            {
                switch (idx)
                {
                    case 0:
                        Col1 = value;
                        break;

                    case 1:
                        Col2 = value;
                        break;

                    case 2:
                        Col3 = value;
                        break;

                    case 3:
                        Col4 = value;
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public static InventoryRow New(List<MapAgentItem> items, ref int i)
        {
            InventoryRow row = new InventoryRow()
            {
                Col1 = items[i].Id,
                Col2 = items[i + 1].Id,
                Col3 = items[i + 2].Id,
                Col4 = items[i + 3].Id,
            };

            i += ColCount;

            return row;
        }
    }
}