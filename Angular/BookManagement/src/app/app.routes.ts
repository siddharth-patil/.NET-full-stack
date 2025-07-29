import { Routes } from '@angular/router';
import { Home } from './home/home';
import { AddBook } from './add-book/add-book';
import { ShowBooks } from './show-books/show-books';

export const routes: Routes = [
    {path:'',component:Home},
    {path:'home',component:Home},
    {path:'add-book',component:AddBook},
    {path:'show-books',component:ShowBooks}
];
