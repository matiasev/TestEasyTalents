import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Talent } from "./talent";

import { Observable } from 'rxjs/Observable';

import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/map';



@Injectable()
export class TalentService {

    private url = 'http://localhost:59695/';

    constructor(private http: Http) { }

    getTalents(): Promise<Talent[]> {
        return this.http.get(this.url + 'api/Talent')
            .toPromise()
            .then(res => res.json())
            .catch(this.error);
    }

    getTalent(id: string): Promise<Talent> {
        return this.http.get(this.url + 'api/Talent/' + id)
            .toPromise()
            .then(response => response.json())
            .catch(this.error);

    }

    postTalent(talent: Talent): Promise<Talent> {
        
        return this.http.post(this.url + 'api/Talent/', talent)
            .toPromise()
            .then(res => res.json())
            .catch(this.error);
    }

    updateTalent(talent: Talent): Promise<Talent> {

        return this.http.put(this.url + 'api/Talent/' + talent.talentID, talent)
            .toPromise()
            .then(() => talent)
            .catch(this.error);
    }

    deleteTalent(id: number): Promise<any> {
        return this.http.delete(this.url + 'api/Talent/' + id)
            .toPromise()
            .then(() => null)
            .catch(this.error);
    }

    private error(error: any): Promise<any> {
        console.error('Error', error);
        return Promise.reject(error.message || error);
    }
}
