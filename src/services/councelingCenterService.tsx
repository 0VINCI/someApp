import axios from 'axios';
import { CounselingCenter } from '../types/CounselingCenter';

const apiUrl = process.env.REACT_APP_API_URL;

const getCounselingCenters = async(): Promise<CounselingCenter[]> => {
    try{
        const response = await axios.get(`${apiUrl}/counselingCenters`);
        return response.data;
    }
    catch(error){
        console.log('Blad podczas nawiazywania polaczenia z api', error);
        throw error;
    }
}
const getCounselingCenterById = async(id: string): Promise<CounselingCenter> => {
    try{
        const response = await axios.get(`${apiUrl}/counselingCenters/${id}`);
        return response.data;
    }
    catch(error){
        console.log('Blad podczas nawiazywania polaczenia z api', error);
        throw error;
    }
}