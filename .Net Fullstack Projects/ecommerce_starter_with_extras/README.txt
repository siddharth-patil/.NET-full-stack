Angular-20 eCommerce Starter (Extras)
====================================

What's inside:
- src/ : Angular source files (components, services, models)
  - Auth scaffolding (mock login, auth service, guard)
  - Product categories + search bar
  - Cart service
- assets/products.json : sample products with categories (images from Unsplash)

How to use:
1. Generate a fresh Angular 20 project (recommended) using Angular CLI:
   ng new ecommerce-app --routing --style=css
2. Replace the generated project's src/ folder with the contents of this src/ folder.
   (Make a backup of the original src if needed.)
3. Install Bootstrap:
   npm install bootstrap@5
   and add to angular.json styles array or import in src/styles.css.
4. Run:
   ng serve --open

Notes:
- This starter uses a mock authentication service (no real backend). It stores a fake JWT in localStorage.
- For production, replace mock services with real APIs.
