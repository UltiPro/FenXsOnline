app.post(apiBaseUrl + "Account/refreshtoken").then(
  (_) => _,
  (_) => window.location.replace("./index.html")
);
