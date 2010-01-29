using System;
using System.Collections.Generic;
using System.Text;

namespace Csla.Test.LazyLoad
{
  [Serializable]
  public class AChildList : Csla.BusinessBindingListBase<AChildList, AChild>
  {
    public AChildList()
    {
      MarkAsChild();
      this.Add(new AChild());
    }

    public int EditLevel
    {
      get { return base.EditLevel; }
    }
  }
}