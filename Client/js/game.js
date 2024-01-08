$('#leave-button').bind("click", () =>{
    app.put(apiBaseUrl + "Hero/leave").then(
        window.location.replace("./start.html")
    )
});