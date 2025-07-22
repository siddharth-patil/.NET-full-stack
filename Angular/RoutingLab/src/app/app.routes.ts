import { Routes } from '@angular/router';
import { Home } from './home/home';
import { Component } from '@angular/core';
import { Members } from './members/members';
import { AboutUs } from './about-us/about-us';
import { Events } from './events/events';
import { PageNotFound } from './page-not-found/page-not-found';
import { AllEvents } from './all-events/all-events';

export const routes: Routes = [
    {path:'Events',component:Events},
    {path:'all-events',component:AllEvents},
    {path:'Members',component:Members},
    {path:'AboutUs',component:AboutUs},
    {path:'',component:Home},
    {path:'**',component:PageNotFound}
];
