(function(){
    var PanelForm = {}
    window.addEventListener("load", PanelFormLoaded);
    document.addEventListener("contextmenu", PanelFormContextMenu);
    function PanelFormLoaded(){   
        PanelForm.StartTimer = false;
        PanelForm.CreatedContextMenu = false;
        PanelForm.PanelDivContainer = document.getElementById("container");
        PanelForm.CMContainer = document.createElement("div");
        PanelForm.CMMenuPanel = document.createElement("div");
        PanelForm.CMMenuText = document.createElement("p");
        PanelForm.CMSetupPanel = document.createElement("div");
        PanelForm.CMSetupText = document.createElement("p");
    }
    function PanelFormContextMenu(e){
        if(e.which === 3 || e.keyCode === 3 || e.button === 2){
            e.preventDefault();
            if(PanelForm.CreatedContextMenu == false){
                //Container
                PanelForm.CMContainer.style.position = "absolute";
                PanelForm.CMContainer.style.zIndex = 100;
                PanelForm.CMContainer.style.width = 150 + "px";
                PanelForm.CMContainer.style.height = 62 + "px";
                PanelForm.CMContainer.style.border = "1px solid red";
                //Menu Panel
                PanelForm.CMMenuPanel.style.position = "absolute";
                PanelForm.CMMenuPanel.style.top = 0 + "px";
                PanelForm.CMMenuPanel.style.left = 0 + "px";
                PanelForm.CMMenuPanel.style.width = 100 + "%";
                PanelForm.CMMenuPanel.style.height = 30 + "px";
                PanelForm.CMMenuPanel.style.backgroundColor = "#696969";
                PanelForm.CMMenuPanel.style.textAlign = "center";
                //Menu Text
                PanelForm.CMMenuText.style.height = 30 + "px";
                PanelForm.CMMenuText.style.lineHeight = 30 + "px";
                PanelForm.CMMenuText.style.margin = 0 + "px";
                PanelForm.CMMenuText.style.padding = 0 + "px";
                PanelForm.CMMenuText.innerHTML = "Menu";
                PanelForm.CMMenuText.style.fontFamily = "Arial";
                PanelForm.CMMenuText.style.fontSize = 20 + "px";
                //Setup Panel
                PanelForm.CMSetupPanel.style.position = "absolute";
                PanelForm.CMSetupPanel.style.top = 30 + "px";
                PanelForm.CMSetupPanel.style.left = 0 + "px";
                PanelForm.CMSetupPanel.style.width = 100 + "%";
                PanelForm.CMSetupPanel.style.height = 30 + "px";
                PanelForm.CMSetupPanel.style.backgroundColor = "#C0C0C0";
                PanelForm.CMSetupPanel.style.textAlign = "center";
                //Setup Text
                PanelForm.CMSetupText.style.height = 30 + "px";
                PanelForm.CMSetupText.style.lineHeight = 30 + "px";
                PanelForm.CMSetupText.style.margin = 0 + "px";
                PanelForm.CMSetupText.style.padding = 0 + "px";
                PanelForm.CMSetupText.innerHTML = "Setup";
                PanelForm.CMSetupText.style.fontFamily = "Arial";
                PanelForm.CMSetupText.style.fontSize = 20 + "px";
                //Appending
                PanelForm.CMMenuPanel.appendChild(PanelForm.CMMenuText);
                PanelForm.CMSetupPanel.appendChild(PanelForm.CMSetupText);
                PanelForm.CMContainer.appendChild(PanelForm.CMMenuPanel);
                PanelForm.CMContainer.appendChild(PanelForm.CMSetupPanel);
                PanelForm.PanelDivContainer.appendChild(PanelForm.CMContainer);
                PanelForm.CreatedContextMenu = true;
            }
            PanelForm.CMContainer.style.top = e.clientY + 1 + "px";
            PanelForm.CMContainer.style.left = e.clientX + 1 + "px";
            PanelForm.StartTimer = true;
            PanelForm.CMContainer.addEventListener("mouseenter", MouseEnteredCMContainer);
            window.setInterval(ContextMenuTimer, 1500);
            function MouseEnteredCMContainer(){
                PanelForm.StartTimer = false;
            }
            function ContextMenuTimer(){
                if(PanelForm.StartTimer == true){
                    alert("HUIIIIIIIIII");
                    PanelForm.StartTimer = false;
                }
                else
                {
                        
                }
            }
        }
    }
})();
