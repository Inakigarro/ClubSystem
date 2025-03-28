import { Component, Input } from "@angular/core";
import { MatSidenavModule } from "@angular/material/sidenav";

@Component({
	selector: "ig-drawer",
	templateUrl: "./drawer.component.html",
	styleUrl: "./drawer.component.scss",
	standalone: true,
	imports: [MatSidenavModule],
})
export class DrawerComponent {
	@Input()
	public position: "start" | "end" = "start";
	@Input()
	public mode: "over" | "push" | "side" = "side";
	@Input()
	public opened: boolean | null = true;
}
