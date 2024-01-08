$('#leave-button').bind("click", () =>{
    app.get(apiBaseUrl + "Hero/leave").then(
        window.location.replace("./start.html")
    )
  
});