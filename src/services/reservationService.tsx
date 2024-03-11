import axios from 'axios';
import { Reservation } from '../types/Reservation';

const apiUrl = process.env.REACT_APP_API_URL;

const getReservations = async (): Promise<Reservation[]> => {
try {
    const response = await axios.get(`${apiUrl}/reservations`);
    return response.data;
  } catch(error){
    console.log('Blad podczas nawiazywania polaczenia z api', error);
    throw error;
}
}

const createReservation = async(reservation: Reservation) => {
    try {
        const response = await axios.post(`${apiUrl}/createreservation`, reservation);
        return response.data;
    }
    catch(error){
        console.log('Blad podczas wykonywania operacji', error);
        throw error;
    }
}

const changeReservation = async(reservation: Reservation) => {
    try {
        const response = await axios.put(`${apiUrl}/changereservation`, reservation);
        return response.data;
    }
    catch(error){
        console.log('Blad podczas wykonywania operacji', error);
        throw error;
    }
}