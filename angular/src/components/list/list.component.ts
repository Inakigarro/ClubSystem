import { Component, Input } from "@angular/core";
import { MatTableModule } from "@angular/material/table";

@Component({
	selector: "ig-list",
	templateUrl: "./list.component.html",
	standalone: true,
	imports: [MatTableModule],
})
export class ListComponent<TItem extends {}> {
	@Input()
	public items: TItem[] = [];

	protected headers: (string & keyof TItem)[] = [];
}
