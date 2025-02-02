import { AttributeTypeMap } from "./models";
export declare class TeamParentResponse {
    "teamId"?: string;
    "name"?: string;
    static discriminator: string | undefined;
    static attributeTypeMap: AttributeTypeMap;
    static getAttributeTypeMap(): AttributeTypeMap;
    static init(data: any): TeamParentResponse;
}
