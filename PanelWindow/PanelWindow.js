(function(){
    var PanelForm = {}
    window.addEventListener("load", PanelFormLoaded);
    document.addEventListener("contextmenu", PanelFormContextMenu);
    function PanelFormLoaded(){   
        PanelForm.CreatedContextMenu = false;
        PanelForm.PanelDivContainer = document.getElementById("container");
        PanelForm.CMContainer = document.createElement("div");
        PanelForm.CMMenuPanel = document.createElement("div");
    }
    function PanelFormContextMenu(e){
        if(e.which === 3 || e.keyCode === 3 || e.button === 2){
            e.preventDefault();
            if(PanelForm.CreatedContextMenu == false){
                PanelForm.CMContainer.style.position = "absolute";
                PanelForm.CMContainer.style.zIndex = 999;
                PanelForm.CMContainer.style.width = "150px";
                PanelForm.CMContainer.style.height = "60px";
                PanelForm.CMContainer.style.border = "1px solid red";
                PanelForm.CMContainer.appendChild(PanelForm.CMMenuPanel);
                PanelForm.PanelDivContainer.appendChild(PanelForm.CMContainer);
                PanelForm.CreatedContextMenu = true;
            }
            PanelForm.CMContainer.style.top = e.clientY + "px";
            PanelForm.CMContainer.style.left = e.clientX + "px";
        }
    }
})();
