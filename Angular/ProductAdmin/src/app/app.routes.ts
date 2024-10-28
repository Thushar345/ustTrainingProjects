import { Routes } from '@angular/router';
import { ListComponent } from './list/list.component';
import { AddNewComponent } from './add-new/add-new.component';
import { DetailsComponent } from './details/details.component';
import { UpdateComponent } from './update/update.component';
import { DeleteComponent } from './delete/delete.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
    {path: "home", component:HomeComponent},
    {path: "list",component:ListComponent},
    {path: "add-new",component:AddNewComponent},
    {path: "details",component:DetailsComponent},
    {path: "update",component:UpdateComponent},
    {path: "delete",component:DeleteComponent},
    {path: "", redirectTo:"home", pathMatch:"full"}
];
