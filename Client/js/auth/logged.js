app.put(apiBaseUrl + "Account/refreshtoken").then(
  (_) => window.location.replace("./start.html"),
  (_) => _
);
