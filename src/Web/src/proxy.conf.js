const PROXY_CONFIG = [
  {
    context: [
      "/client",
    ],
    target: "https://localhost:7193",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
