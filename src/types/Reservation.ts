export interface Reservation {
    ReservationId: number;
    RoomId: number;
    PsychologistName: string;
    PhoneNumber: string;
    DateFrom: Date;
    DateTo: Date;
    IsRemoved: boolean;
}