import { createSlice } from '@reduxjs/toolkit';
import { CounselingCenter } from '../types/CounselingCenter';
import { RootState } from '../store';
import { getCounselingCenters } from '../services/councelingCenterService';

export interface CounselingCenterListState {
    data: CounselingCenter[];
    isLoading: boolean;
    loadError: Object | null;
}

const initialState: CounselingCenterListState = {
    data: [],
    isLoading: false,
    loadError: null
}

export const counselingCenterListSlice = createSlice({
    name: 'councelingCenterList',
    initialState,
    reducers: {
    },
    extraReducers: (builder) => {
            builder.addCase(getCounselingCenters.pending, (state) => {
            state.loadError = null;
            state.isLoading = true;
        })

        builder.addCase(getCounselingCenters.fulfilled, (state, { payload }) => {
            state.data = payload;
            state.isLoading = false;
        })

        builder.addCase(getCounselingCenters.rejected, (state, payload : any) => {
            state.loadError = payload;
            state.isLoading = false;
        })
    }
})

export const getCouncelingCenters = (state: RootState) => state.counselingCenterList.data;
export const isLoading = (state: RootState) => state.counselingCenterList.isLoading;

export default counselingCenterListSlice.reducer;