import { Routes } from '@angular/router';
import { AllProducts } from './component/all-products/all-products';
import { AddProduct } from './component/add-product/add-product';

export const routes: Routes = [
    {path:'allproduct',component:AllProducts},
    {path:'addproduct',component:AddProduct}
];
