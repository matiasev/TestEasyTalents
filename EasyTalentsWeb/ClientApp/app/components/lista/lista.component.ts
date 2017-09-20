import { Component, OnInit } from '@angular/core';
import { TalentService } from "../../talent.service";
import { Location } from '@angular/common';
import { Talent } from "../../talent";


@Component({
    selector: 'lista',
    templateUrl: './lista.component.html'
})
export class ListaComponent implements OnInit {

    private talents: Talent[];

    constructor(
        private talentService: TalentService,
        private location: Location
    )
    { }


    ngOnInit() {
        this.listar();
    }

    listar() {
        this.talentService.getTalents()
            .then(talent => this.talents = talent);
    }

    delete(item: Talent) {
        if (confirm("Are you sure to delete " + item.nome + " ?")) {
            this.talentService.deleteTalent(item.talentID)
                .then(() => this.listar());
        }
        
    }

    goBack(): void {
        this.location.back();
    }
}
