using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Uptick.Models
{
    public class AppState
    {
        public event Action OnChange;
        public void stateChange()
        {
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
