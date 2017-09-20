import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';
import { TalentService } from "../../talent.service";
import { Talent } from "../../talent";

import 'rxjs/add/operator/map';

@Component({
    selector: 'detalhe',
    templateUrl: './detalhe.component.html',
    styleUrls: ['./detalhe.component.css']
})
export class DetalheComponent implements OnInit{

    private id: string;
    talents: Talent;

    constructor(
        private talentService: TalentService,
        private route: ActivatedRoute,
        private location: Location
    ) { }

    ngOnInit() {
        this.id = this.route.snapshot.params['id'];
        this.talentService.getTalent(this.id)
            .then(talent => this.talents = talent);

        console.log(this.talents);
    }

    goBack(): void {
        this.location.back();
    }

}
