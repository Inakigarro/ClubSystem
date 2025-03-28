import { NgModule } from "@angular/core";
import { MembersRoutingModule } from "./members-routing.module";
import { MembersRoutingComponent } from "./members-routing.component";
import { MembersListComponent } from "./members-list/members-list.component";

@NgModule({
	declarations: [MembersRoutingComponent, MembersListComponent],
	imports: [MembersRoutingModule],
	exports: [],
})
export class MembersModule {}
