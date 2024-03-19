import axios from 'axios';
import { CounselingCenter } from '../types/CounselingCenter';
import { createAsyncThunk } from '@reduxjs/toolkit';

const apiUrl = process.env.REACT_APP_API_URL;
const ERROR_MESSAGE = 'Blad podczas nawiazywania polaczenia z api'

export const getCounselingCenters = createAsyncThunk<CounselingCenter[], number>(
    'counselingCenters',
    async (type: number, thunkApi) => {
        const response = await axios.get(`${apiUrl}/counselingCenters`); 
    if (response === undefined) {
        return thunkApi.rejectWithValue({
            message: ERROR_MESSAGE
        });
    } else {
        return response.data;
    }
});

const getCounselingCenterById = async(id: string): Promise<CounselingCenter> => {
    try{
        const response = await axios.get(`${apiUrl}/counselingCenters/${id}`);
        return response.data;
    }
    catch(error){
        console.log(ERROR_MESSAGE);
        throw error;
    }
}