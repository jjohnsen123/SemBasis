using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace lek07opg1.Infrastructure
{
    public class Utilities
    {
        public static void SortSelectList(List<SelectListItem> selectList)
        {
            ArrayList textList = new ArrayList();
            ArrayList valueList = new ArrayList();

            foreach (SelectListItem li in selectList)
            {
                textList.Add(li.Text);
            }

            textList.Sort(StringComparer.CurrentCultureIgnoreCase);

            foreach (object item in textList)
            {
                SelectListItem li = selectList.Find(x => x.Text.Equals(item.ToString(), StringComparison.OrdinalIgnoreCase));
                valueList.Add(li.Value);
            }

            selectList.Clear();

            for (int i = 0; i < textList.Count; i++)
            {
                selectList.Add(new SelectListItem { Text = textList[i].ToString(), Value = valueList[i].ToString() });
            }
        }
    }

}
