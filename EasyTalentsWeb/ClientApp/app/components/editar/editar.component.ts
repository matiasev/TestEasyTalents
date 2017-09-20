import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';
import { TalentService } from "../../talent.service";
import { Talent } from "../../talent";


@Component({
    selector: 'editar',
    templateUrl: './editar.component.html',
    styleUrls: ['./editar.component.css']
})
export class EditarComponent implements OnInit{

    public tipoConta = [
        { value: 'C', display: 'Corrente' },
        { value: 'P', display: 'Poupança' }
    ];

    private id: string;
    talent: Talent;

    constructor(
        private talentService: TalentService,
        private route: ActivatedRoute,
        private location: Location
    ) { }

    ngOnInit(): void {
        this.id = this.route.snapshot.params['id'];
        this.talentService.getTalent(this.id)
            .then(talent => this.talent = talent);

        console.log(this.talent);
    }

    salvar(): void {
        this.talentService.updateTalent(this.talent)
            .then(() => alert("Alteração feita com sucesso!"))
            .then(() => this.goBack());
    }

    goBack(): void {
        this.location.back();
    }

}
