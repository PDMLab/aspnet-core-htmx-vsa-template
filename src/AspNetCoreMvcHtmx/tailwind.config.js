module.exports = {
  content: ["**/*.{cshtml,js}"],
  safelist: [
    'input-validation-error'
  ],
  theme: {
    extend: {},
  },
  plugins: [
    require("@tailwindcss/forms")({
      strategy: "class",
    }),
  ],
}
