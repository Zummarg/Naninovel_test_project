using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;


namespace Naninovel.Commands
    {
    [CommandAlias("minigame")]
    public class Test_class : Command
    {  
        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            var customService = Engine.GetService<Minigame_custom_service>();
            customService.InitializeServiceAsync();
            return UniTask.CompletedTask;
        }

    }
}

