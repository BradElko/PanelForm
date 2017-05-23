(function(){
    var PanelForm = {}
    window.addEventListener("load", PanelFormLoaded);
    function PanelFormLoaded(){   
        PanelForm.StartTimer = false;
        PanelForm.InvisibleContextMenu = true;
        PanelForm.PanelDivContainer = document.getElementById("container");
        PanelForm.ValidClickArea = document.createElement("div");
        PanelForm.InvalidClickArea = document.createElement("div");
        PanelForm.CMContainer = document.createElement("div");
        PanelForm.CMMenuPanel = document.createElement("div");
        PanelForm.CMMenuText = document.createElement("p");
        PanelForm.CMSetupPanel = document.createElement("div");
        PanelForm.CMSetupText = document.createElement("p");
        PanelForm.BP = document.getElementById("bottomPanel");
        PanelForm.TP = document.getElementById("topPanel");
        PanelForm.BP.addEventListener("contextmenu", PanelFormContextMenu);
        PanelForm.TP.addEventListener("contextmenu", DisableContextMenu);
        window.addEventListener("contextmenu", DisableContextMenu);
    }
    function PanelFormContextMenu(e){
        if(e.which === 3 || e.keyCode === 3 || e.button === 2){
            e.preventDefault();
            if(PanelForm.InvisibleContextMenu == true){
                //ValidClickArea
                PanelForm.ValidClickArea.style.position = "absolute";
                PanelForm.ValidClickArea.style.display = "none";
                PanelForm.ValidClickArea.style.top = 10 + "px"
                PanelForm.ValidClickArea.style.left = 9 + "px"
                PanelForm.ValidClickArea.style.width = PanelForm.BP.offsetWidth - 18 + "px";
                PanelForm.ValidClickArea.style.height = PanelForm.BP.offsetHeight - 20 + "px";
                PanelForm.ValidClickArea.style.backgroundColor = "Green";
                //InvalidClickArea
                PanelForm.InvalidClickArea.style.position = "absolute";
                PanelForm.InvalidClickArea.style.display = "none";
                PanelForm.InvalidClickArea.style.top = 0 + "px";
                PanelForm.InvalidClickArea.style.left = 0 + "px";
                PanelForm.InvalidClickArea.style.width = PanelForm.BP.offsetWidth + "px";
                PanelForm.InvalidClickArea.style.height = PanelForm.BP.offsetHeight+ "px";
                PanelForm.InvalidClickArea.style.backgroundColor = "Red";
                //Container
                PanelForm.CMContainer.style.position = "absolute";
                PanelForm.CMContainer.style.display = "block";
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
                PanelForm.BP.appendChild(PanelForm.InvalidClickArea);
                PanelForm.BP.appendChild(PanelForm.ValidClickArea);
                PanelForm.InvisibleContextMenu = false;
                //Other
                PanelForm.CMContainer.addEventListener("contextmenu", DisableContextMenu);
            }
            //Left
            if((e.clientX > 8) 
                    && (e.clientY + PanelForm.CMContainer.offsetHeight < window.innerHeight - 9
                    && e.clientX + PanelForm.CMContainer.offsetWidth < window.innerWidth - 8
                    && e.clientX + (PanelForm.CMContainer.offsetWidth / 2) < (window.innerWidth / 2)
                    && e.clientY + (PanelForm.CMContainer.offsetHeight / 2) < (window.innerHeight / 2)
                    && e.clientY > 39)){
                PanelForm.CMContainer.style.top = e.clientY - 3 + "px";
                PanelForm.CMContainer.style.left = e.clientX - 3 + "px";
            }
            //Top Middle
            else if(e.clientY < (window.innerHeight / 2)
                    && e.clientX + (PanelForm.CMContainer.offsetWidth / 2) < (window.innerWidth / 2) 
                    || e.clientX + (PanelForm.CMContainer.offsetWidth / 2) == (window.innerWidth / 2) 
                    || e.clientX + (PanelForm.CMContainer.offsetWidth / 2) > (window.innerWidth / 2)
                    && (window.innerWidth / 2) - e.clientX < 151
                    && e.clientX - (window.innerWidth / 2) < 151){
                PanelForm.CMContainer.style.top = e.clientY - 3 + "px";
                PanelForm.CMContainer.style.left = e.clientX - (PanelForm.CMContainer.offsetWidth/2) + 3 + "px";
            }
            //Right
            else if((window.innerWidth - e.clientX > 9)
                    && (window.innerWidth - e.clientX > 8
                    && window.innerHeight - (e.clientY + PanelForm.CMContainer.offsetHeight) > 9
                    && e.clientX + (PanelForm.CMContainer.offsetWidth / 2) > (window.innerWidth / 2)
                    && e.clientY + (PanelForm.CMContainer.offsetHeight / 2) < (window.innerHeight / 2)
                    && e.clientY > 39)){
                PanelForm.CMContainer.style.top = e.clientY - 3 + "px";
                PanelForm.CMContainer.style.left = e.clientX - PanelForm.CMContainer.offsetWidth + 3 + "px";
            }
            //Bottom Left
            else if((e.clientY + PanelForm.CMContainer.offsetHeight > window.innerHeight)
                && (window.innerHeight - e.clientY > 9 
                && e.clientX > 8
                && window.innerWidth - (e.clientX + PanelForm.CMContainer.offsetWidth) > 8)){
                PanelForm.CMContainer.style.top = e.clientY - PanelForm.CMContainer.offsetHeight + 3 + "px";
                PanelForm.CMContainer.style.left = e.clientX - 3 + "px";
            }
            //Bottom Right
            else if((window.innerHeight - e.clientY > 9
                    && window.innerWidth - e.clientX > 8)
                    && (window.innerHeight < e.clientY + PanelForm.CMContainer.offsetHeight 
                    && window.innerWidth < e.clientX + PanelForm.CMContainer.offsetWidth)
                    && (e.clientX - PanelForm.CMContainer.offsetWidth > 8)){
                PanelForm.CMContainer.style.top = e.clientY - PanelForm.CMContainer.offsetHeight + 3 + "px";
                PanelForm.CMContainer.style.left = e.clientX - PanelForm.CMContainer.offsetWidth + 3 + "px";
            }
            else{
                PanelForm.CMContainer.style.display = "none";
                PanelForm.InvisibleContextMenu = true;
            }
            document.onmousemove = getLocationOfCM;
            function getLocationOfCM(e){
                var elTop = PanelForm.CMContainer.getBoundingClientRect().top; 
                var elLeft = PanelForm.CMContainer.getBoundingClientRect().left;
                var elBottom = PanelForm.CMContainer.getBoundingClientRect().bottom;
                var elRight = PanelForm.CMContainer.getBoundingClientRect().right;
                var mouseX = e.clientX;
                var mouseY = e.clientY;
                if(elTop > mouseY || elBottom < mouseY || elLeft > mouseX || elRight < mouseX){
                    PanelForm.CMContainer.style.display = "none";
                    PanelForm.InvisibleContextMenu = true;
                }
            }
        }    
    }
    function DisableContextMenu(e){
        if(e.which === 3 || e.keyCode === 3 || e.button === 2){
            e.preventDefault();
        }
    } 
})();
