import { Component, OnInit } from '@angular/core';
import { TalentService } from "../../talent.service";
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';
import { Talent } from "../../talent";

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{

    public tipoConta = [
        { value: 'C', display: 'Corrente' },
        { value: 'P', display: 'Poupança' }
    ];

    //talents: Talent[];

    talent = new Talent();

    constructor(
        private talentService: TalentService,
        private route: ActivatedRoute,
        private location: Location
    ) { }

    ngOnInit() {
        
    }

    add() {
        this.talentService.postTalent(this.talent)
            .then(() => alert("Candidato cadastrado com sucesso!"))
            .then(() => this.goBack());


        console.log(this.talent);
    }

    goBack(): void {
        this.location.back();
    }
}
