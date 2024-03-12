export interface AddListingReq {
    price: number;
    bathrooms: number;
    halfBathrooms: number;
    bedrooms: number;
    yearBuilt: number;
    address: string;
    photoUrl: string;
    latitude: number;
    longitude: number;
}